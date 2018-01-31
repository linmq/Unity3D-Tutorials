﻿﻿﻿﻿﻿#Unity3D-Tutorials (C#)

##Events
[https://unity3d.com/learn/tutorials/topics/scripting/events](https://unity3d.com/learn/tutorials/topics/scripting/events)
Unity3D V5.4.1f1

##Delegates
[https://unity3d.com/learn/tutorials/topics/scripting/delegates](https://unity3d.com/learn/tutorials/topics/scripting/delegates)
Unity3D V5.4.1f1

##Events: Creating a simple messaging system
[https://unity3d.com/learn/tutorials/topics/scripting/events-creating-simple-messaging-system](https://unity3d.com/learn/tutorials/topics/scripting/events-creating-simple-messaging-system)
Unity3D V5.4.1f1

##UnityEvent
[https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html](https://docs.unity3d.com/ScriptReference/Events.UnityEvent.html)
Unity3D V5.5.2f1

##UnityEvent
[https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html](https://docs.unity3d.com/ScriptReference/Events.UnityEvent_1.html)
Unity3D V5.5.2f1

##BuildingPluginsForiOS-Bonjour
[https://docs.unity3d.com/Manual/PluginsForIOS.html](https://docs.unity3d.com/Manual/PluginsForIOS.html)
Unity3D V5.5.2f1
When build to Xcode project, the file BonjourClientlmpl.mm is write by MRC, you need to set “-fno-objc-arc” at Xcode -> Build Phases -> Copile Sources -> Compiler Flags

##BuildingPluginsForiOS-Brightness
Unity3D V5.5.2f1
Unity3D call iOS’s native code to Set iOS device’s brightness at 1.0, and set brightness at 0.5 when paused.

##Build Dll file For Unity3D
Unity3D V5.4.1f1 Visual Studio 2015
Build C# project to Dll file, and use the Dll in Unity3D
[https://docs.unity3d.com/Manual/UsingDLL.html](https://docs.unity3d.com/Manual/UsingDLL.html)

##Build Dll file For Unity3D with Macro(#if UNITY_IOS)
It need to add “UNITY_IOS" to Project's properties -> Build -> General -> Conditional compilation symbols
Visual Studio 2015
