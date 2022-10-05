using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using TimeAndAttendanceToCsv.Models;
using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Collections;

namespace TimeAndAttendanceToCsv
{
    public class TimeAttLogic
    {
        private string access_token;
        private List<EventDataModel> data;
        private List<CustomTimeAndAttendanceModel> customData;

        private async Task GetAccessToken(appsettingsModel settings)
        {
            using (HttpClient c = new HttpClient())
            {
                var postData = new APIAccessTokenRequestModel
                {
                    client_id = settings.clientId,
                    grant_type = "password",
                    scope = "offline_access",
                    username = settings.username,
                    password = settings.password,
                };

                var result = await c.PostAsJsonAsync($"{settings.host}/api/v1/authorization/tokens", postData);
                var response = await result.Content.ReadFromJsonAsync<APIAccessTokenResponseModel>();
                access_token = response.access_token;
            }
        }
        public async Task GetTimeAndAttendanceData(appsettingsModel settings)
        {
            await GetAccessToken(settings);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", access_token);
                var result = await client.GetFromJsonAsync<List<EventDataModel>>($"{settings.host}/api/v1/events?where=EventDescription='Time and attendance'&orderBy=eventid asc");
                data = result;
            }
        }
        public async Task GetCustomTimeAndAttendanceData(appsettingsModel settings)
        {
            await GetAccessToken(settings);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", access_token);
                var result = await client.GetFromJsonAsync<List<CustomTimeAndAttendanceModel>>($"{settings.host}/api/v1/customquery/querydb?query=SELECT 'pAT' as 'StaticData', Field14_50 as 'EmployeeID', EventSubTypeDescription as 'inout', EventTime from sdk.EventsEx INNER JOIN sdk.UsersEx ON sdk.EventsEx.UserID = sdk.UsersEx.UserID where EventTypeDescription = 'Time and attendance'");
                customData = result;
            }
        }
        public void createCSV()
        {
            using (var writer = new StreamWriter($"ClockInData.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(data);
            }
        }
        public void createCustomCSV()
        {
            using (var writer = new StreamWriter($"ClockInData.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(customData);
            }
        }
    }
}
