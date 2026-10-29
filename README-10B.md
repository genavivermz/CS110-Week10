# CS110 / Action 10B / Three Hello World Investigations

Current phase: independent study with teams and tools.

## My transfer note / saved in the same README

[Not yet recorded]

## Lecture investigation notes

1. Programming languages are abstractions of binary
2. Void = method returns no value
3. Define the action once we’ve declared our variables (like console outputs)
One question: How do programming language developers ensure their language follows the standard code syntax?
My contribution: Solo work
Prediction: Moving my Bedwars logic across environments will keep the data and methods the same.
What I tried: Mapped out Bed class structure across console, WPF, and Unity script
Result: Core class and BuildMessage() logic remained reusable across environments
What it means: Building with the end result in mind allows data and action logic to be nicely carried across each step without needing to refactor code each time.
Evidence/

## Console investigation notes

Will show “Hello, world, Ari!”
Tried to just use $ to create a flexible Hello, world statement.
Not sustainable, might want to change text later on —> use variable name Greeting
Next step is to start experimenting with different names
Console/Greeting.cs
Console/Program.cs

## XAML / WPF investigation notes

Shows greeting text with a Say Hello button
C# code-behind makes the button function
Prediction: Say Hello button triggers SayHello_Click event handler & display greeting string in the WPF window
Result: App built successfully, clicking button updates text box to display greeting
Next step: Demos how UI components in XAML can be updated through C# code-behind logic
WPF/MainWindow.xaml.cs
WPF/MainWindow.xml

## Engine investigation notes

Unity 6 / C#
https://unity.com/
GameObject (Beacon)
Question: Why is the output message missing and causing missing reference error? —> Source check: verified that Unity compiles scripts within the Assets folder and requires referenced classes —> test: Placed Greeting class definition inside the Unity script —> decision: keep self-contained class structure inside Unity
Prediction: Once missing class file or definition is included, it will successfully print the status message to the Unity console
I tried: Placed Message object in the scene, attached script, Play mode, encountered compilation error because the separate console/WPF script containing class def wasn’t in Unity project directory.
Result: CS1061: ‘Greeting’ does not contain a definition for ‘BuildMessage’
What it means: Unity requires all dependent C# classes to be included as assets within the project folder; add the Greeting.cs script file into assets, recompile, and verify the message appears in the Unity console.
EngineTrial/
Evidence/

## Working arrangement
Solo



## My handoff
GitHub: https://github.com/genavivermz/CS110-Week10
Required: Console/, WPF/, EngineTrial/, Evidence/ and cs110-10b-receipt.txt.
Canvas: https://sbccd.instructure.com/courses/66804/assignments/1913888
This record does not verify submission or grading.
