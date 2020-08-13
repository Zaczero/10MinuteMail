# 10MinuteMail

[![Build Status](https://travis-ci.com/Zaczero/10MinuteMail.svg?branch=master)](https://travis-ci.com/Zaczero/10MinuteMail)
[![GitHub Release](https://img.shields.io/github/v/release/Zaczero/10MinuteMail)](https://github.com/Zaczero/10MinuteMail/releases/latest)
[![NuGet Release](https://img.shields.io/nuget/v/10MinuteMail.com)](https://www.nuget.org/packages/10MinuteMail.com/)
[![License](https://img.shields.io/github/license/Zaczero/10MinuteMail)](https://github.com/Zaczero/10MinuteMail/blob/master/LICENSE)

Simple HTTP API wrapper for [10minutemail.com](https://10minutemail.com/)

## 🌤️ Installation

### Install with NuGet (recommended)

`Install-Package 10MinuteMail.com`

### Install with dotnet

`dotnet add PROJECT package 10MinuteMail.com`

### Install manually

[Browse latest GitHub release](https://github.com/Zaczero/10MinuteMail/releases/latest)

## 🏁 Getting started

### Sample code

```cs
var tenMinuteMail = new TenMinuteMail();

// get 10 minute email address
var email = await tenMinuteMail.GetEmail();
// seconds left till expiration
var secondsLeft = await tenMinuteMail.GetSecondsLeft();

// reset time to 10 minutes
await tenMinuteMail.ResetTime();

// message count
var messageCount = await tenMinuteMail.GetMessageCount();
// messages aka. mails
var messages = await tenMinuteMail.GetMessages();
```

View the [Mail structure](https://github.com/Zaczero/10MinuteMail/blob/master/10MinuteMail/Mail.cs)

## Footer

### 📧 Contact

* Email: [kamil@monicz.pl](mailto:kamil@monicz.pl)
* PGP: [0x9D7BC5B97BB0A707](https://gist.github.com/Zaczero/158da01bfd5b6d236f2b8ceb62dd9698)

### 📃 License

* [Zaczero/10MinuteMail](https://github.com/Zaczero/10MinuteMail/blob/master/LICENSE)
* [JamesNK/Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md)
