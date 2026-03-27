# FinalProjectSubmission
TeleoperativeRoboticsAndVR
This prototype explores the use of Virtual Reality(VR) in relation to motor skill disabilities. The aim of the project is to provide and immersive VR environment in which drawing can occur utilising a robotic arm intermediary to alleviate some of the concerns related to motor skill disabilities, such as Parkinsons and complications of Arthritis. 
The system was implemented using Unity game engine for deployment on Meta Quest 2 and 3 devices. Animation Rigging package was used to implement kinematics for the robotic arm and XR interaction toolkit was used for input handling. C# scripting adds functionality to the system including drawing, saving images, haptic feedback through the controllers and additional functionality for the IK system.  

Running the Prototype:
Aside - Requires a Meta Quest 2 or 3 VR headset and controllers.  
1: Download a .zip copy of the project from this github repository and extract it to a location on your local computer.  
2: Install Unity Hub -https://unity.com/download- Create a Unity account if you do not have one already and follow the steps for installation.  
3: Once installed, install the newest version of 6000 editor by going to the editors tab and select install editor. Follow the steps to install the editor making sure that android build support including openjdk and android sdk/ndk tools are checked.  
4: Install the Meta Horizon Link software - https://www.meta.com/en-gb/help/quest/1517439565442928/?srsltid=AfmBOoq8p5ucoiKk4ADmQKg6-nCUHReo1de2BldGGdP7dRCO2tM0ocEl - click on download app and follow installation steps. Create a Meta account for this if one is not already available.  
5:Open the Meta Horizon Link app and go to the devices tab, select add headset, Follow steps for adding your device to the Meta Horizon Link app, either through cable link or airlink.  
6:Open Unity Hub go to projects and select the add dropdown menu and select add from disk. Locate the extracted copy of this project and add it to the hub.  
7: Double click the added project in the projects tab to open and allow it time to install the required packages already embedded in the project files.  
8:Once the Unity Editor opens, navigate to assets/scenes and double click the samplescene in the project explorer to show the scene.  
9:Connect your Quest device to the computer by clicking on the meta button on the right controller. Selecting link from the menu and then connecting via airlink if the headset is on the same wifi network, or using a usb C cable attached to the headset and computer. Make sure Meta Horizon Link app is open during this process and that steps 5 and 6 have been completed.  
10: Once the headset is connectedd to the computer, click the meta button on the right controller again to bring up a menu in the VR environment and select desktop, this will provice a view of the computers desktop on the headset.  
11: navigate the controller to the top of the Unity Editor and select the Play button at the top centre. This will compile the project and run it on the headset for testing.  
12: Use the VR environment  

C# Scripts added for functionality can be found in Assets/Canvas/Scripts
