# Udacity Carnival
Starter project for the Udacity [VR Developer Nanodegree](http://udacity.com/vr) program.

- Course: Introduction to Virtual Reality
- Project: Udacity Carnival


### Versions Used
- [Unity LTS Release 2018.4.0](https://unity3d.com/unity/qa/lts-releases?version=2017.4)
- [GVR SDK for Unity v1.170.0](https://github.com/googlevr/gvr-unity-sdk/releases/tag/v1.170.0)
- [TextMesh Pro](https://assetstore.unity.com/packages/essentials/beta-projects/textmesh-pro-84126) v1.2.2


### Directory Structure
- The Unity project is the child directory of the repository and named according to the associated lesson.
- The Unity project is 'cleaned' and includes my 'Assets', Build', 'ProjectSettings', and 'Screenshots' folders, along with the README.md file. 
- The Unity project does not include the 'Temp, 'Library', 'Packages', and 'UnityPackageManager' folders, as they have been deleted.


### GVR SDK for Unity
- `GoogleVR` > `Demos` is not included.
- `GoogleVR` > `GVRVideoPlayer.unitypackage` is not included.
- The `Max Reticle Distance` value for the `GvrReticlePointer` used in the scene is set to `20` instead of the default `10`.
- Scripts applicable to the course have been updated to reflect Unity's API change from `UnityEngine.VR` to `UnityEngine.XR`.


### My Changes on the Final Project
- I have personalized the Scoreboard text in Scene and Game view to display my FirstName and LastName, instead of Udacity's scores.
- I have aligned the Scoreboard text in Scene and Game view such that no part of the text appears outside of the black area of the Scoreboard.
- I have customized Coin Toss Min and Max Toss Power of the Carnival Coin Toss component accurately.
- I have customize Wheel of Fortune such that the point values are higher for smaller wedges than for larger wedges.
- I have customized Wheel of Fortune such that the point value text displayed on each wedge fits within the edges of the wedge.
- I have customized Plinko Oscillation Distance on the Carnival Plinko component accurately.
- I have positioned the Teddy Bear appropriately such that it does not fall on the player when it drops down as a reward.
- I have provided screenshots of Unity app running both on my Android Phone and Gaming Laptop to reflect the optional changes that have been made to my Carnival app during development such as 'Adding balloons behind the tent to make the carnival feel more lively' and 'Adding a timer to make the game loop more exciting and competitive'.


### My Conclusion
- I really enjoyed developing my 'Carnival App' with all the optional changes and learned a lot during the process. 


### References
1. Brackeys. (2018, May 20). How to Fade Between Scenes in Unity. Retrieved February 10, 2019, from https://www.youtube.com/watch?v=Oadq-IrOazg
2. Games, U. (2016, September 10). How to make a Countdown Timer in Unity 5. Retrieved February 11, 2019, from https://www.youtube.com/watch?v=RLKQhpDxDlE
3. MrBuFF. (2015, September 19). Unity 5 How to Make a Start Menu (For your Game). Retrieved February 10, 2019, from https://www.youtube.com/watch?v=vfi4ZYHR-MU&index=28&list=PLCteXJyIZTSBxXvXqrKtAmyASYujtKx4I&t=0s
4. Tutorials, A. (2017, February 14). Unity 5 C# Particle System for valentine's day with heart balloons. Retrieved February 11, 2019, from https://www.youtube.com/watch?v=QLvE3E040-8&index=71&list=PLCteXJyIZTSBxXvXqrKtAmyASYujtKx4I&t=0s


>**Note:** If for any reason you remove and re-import GVR SDK for Unity v1.170.0, make sure you accept any API update pop-up prompts triggered by Unity. Alternatively, you can manually run the API updater (Unity menu `Assets` > `Run API Updater...`) after the import has completed.
