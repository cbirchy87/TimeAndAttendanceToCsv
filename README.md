# TimeAndAttendanceToCsv
Setup 
1. Open appsettings.json
2. Net2 Operator username and password, also enter ClientID. This is your LocalApiLicenceKey

Running

Open ConsoleRunner.exe and pass in the required args "2013-03-26 00:00:01" "2023-03-26 23:59:59" eg. ConsoleRunner.exe -"2013-03-26 00:00:01" "2023-03-26 23:59:59"
This will get the clockin and out events during this time. 
The csv is written to the same dir as the executing code. 

An example csv is also attached to the project.

Support for this application HAS NOT been implied and will not be provide. This code is not production ready and is only shown as a possible example.
