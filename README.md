# 10MinuteMail

![](https://img.shields.io/github/release/Zaczero/10MinuteMail.svg)
![](https://img.shields.io/nuget/v/10MinuteMail.com.svg)
![](https://img.shields.io/github/license/Zaczero/10MinuteMail.svg)

Simple API wrapper for https://10minutemail.com/

## Download
* https://github.com/Zaczero/10MinuteMail/releases/latest

## Sample code

```cs
var tenMinuteMail = new TenMinuteMail();

var email = await tenMinuteMail.GetEmail(); // get 10 minute email address
var secondsLeft = await tenMinuteMail.GetSecondsLeft(); // seconds left till expiration

await tenMinuteMail.ResetTime(); // reset time to 10 minutes

var messageCount = await tenMinuteMail.GetMessageCount(); // message count
var messages = await tenMinuteMail.GetMessages(); // messages aka. mails
```

View the [Mail structure](https://github.com/Zaczero/10MinuteMail/blob/master/10MinuteMail/Mail.cs)