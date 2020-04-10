Hi there, this program is by Will, Danny and Jennie. 
This application was written as part of Hack Quarantine, to help people in our communuty. Below is some more information about it.

## Inspiration
The inspiration came from a local movement in our area, to post cards through peoples doors and offering them help in these difficult times. The card system allows people to say who they are and what they can offer to others, and the recipient can then call the person on the card to help them get essential supplies - such as food and medicine. The system works great, except people don't know if houses have been delivered to, so they might get multiple cards and if you don't get a card there is no way to request help. Attempts to solve this so far are limited to a Facebook page and a WordPress website. Whilst these are both great, we thought that we could make something better and Hack Quarantine was the perfect opportunity to do it.

## What it does
So far it does not do a lot, however we plan for that to change very quickly over the coming weeks. So far we have made the base template for the app and embedded the google maps API into our app, so that the person in need is easy to find, and help can be on the way as fast as possible (Attached is a screenshot of the current state of the app). When completed, we hope that it is a fully functioning digital replacement for the kindness cards, which also combats the issue of where the cards are, by being able to see which streets have been covered.

## How we built it
We built the program using Xamarin Forms through Visual studio. This means that half of the app is written in XAML, a markup language, and the other half is written in C#. The C# code is where we have defined the functions such as what happens when a button is pressed, etc. We had never used Xamarin Forms before, and we had only done a little bit of C#, but we decided it would be the best way to make the app, as Xamarin allows for cross platform apps between iOS and Android. We have it synced with GitHub which allows it to be edited by all of the team remotely. We are using the Google maps API within Xamarin Forms for the map on the Android app and the Apple maps API for the iOS version of the app.

## Challenges we ran into
We had many issues getting GitHub to sync between all of our laptops - however after getting past that issue we hit many more. Later on, we had trouble getting the buttons to link to other pages, as this is done in C# (A pretty hard language to all of us), but after much trying, we managed to get it to work. After this issue, we had many problems to get the keys that the API key requires to work. This took many attempts as it did not work on everybody's laptop as the keystore files were empty. However, we sorted this issue as it worked on Danny's laptop so we could all use that key. However, the map only builds if it's done on his PC.

## Accomplishments that we're proud of
We are proud of making the map work to the point where we can see it and navigate around the world. We are also proud of our idea, as we believe that it is beneficial for the communities that we live in. We are also proud of the fact that our app can work on android and iOS devices as this means that so many more people can use the app and help others, than if it was just an iOS or just an Android app.

## What we learned
We have learned the fundamentals of Xaramin Forms, and more specifically the XAML language. We all already knew HTML which is quite different, but being a markup language too, it had its similarities. We learnt how to link buttons to other XAML pages, and of course, how to embed Google Maps. We learnt how to use GitHub properly and make sure they were all loading properly (We had never done a group project using GitHub before. We had only used it to store our own personal code). We have also learnt that adding comments to our code is a great idea, because if the next person doesn't understand what you've written, you have a problem. Of course this meant that we also learnt to keep our code nice and organised. We also learnt that having something other than Snapchat to communicate which each other is great, because it keeps everything organised and everything there is to do with the project (not just general Chit Chat). We used Slack because we are not completing the Hackathon at the same location or at the same time, and we can have different channels within the Slack server to make sure we know what's going on. We have also learnt how to organise a project and an idea better into logical steps, to allow us all to make the program work at different stages so that it is obvious what needs to be done by the other team members. Finally, we have learnt how to delegate the tasks to the best person, to make it work best for our app. 

## What's next for KindApp
Our next stages is to make the app collect and retain user data (with consent of course) so that the cards can be put out and people can see who has requested help in their local area and who is willing to offer it. This would need to sync with a database of some description to make it available on all users devices. We would like it to show the map at the location your device is, and not the center of Rome where it is currently showing... Finally, we would like there to be an in-app-messaging-client which allows the users to message one another to co-ordinate the help that they are giving or receiving. We hope that this will all be complete by the end of the Hackathon. We also want to design the app better and make it look professional, however our priority at the moment is getting it fully functioning. We hope that in the future we could publish it to the App Store and the Play Store, for people in communities across the globe to use, to help each other through the time of crisis we are currently living in.

To try it out you will need,
Visual Studio 2019 running on a Windows PC, 
All of the xaramin extenstions running

To use thee android version
An android emulator or Android device

To use the iOS version 
A Mac with Xcode and visual studio for mac installed, and remote login enbaled
An iPhone or iPad or the emulator built in.

We hope you enjoy using our app.
