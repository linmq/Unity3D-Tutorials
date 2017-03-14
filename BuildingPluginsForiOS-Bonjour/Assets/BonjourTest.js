
private var querying : boolean = false;
private var label = "";
private var status = "";

private var centerx = Screen.width / 2;
private var centery = Screen.height / 2;

private var services = new System.String[0];
private var labelStyle : GUIStyle = new GUIStyle();

// Default service name. _daap._tcp corresponds to iTunes music sharing service
private var service = "_daap._tcp";

function Start () 
{
	labelStyle.alignment = TextAnchor.MiddleCenter;
	labelStyle.normal.textColor = Color.white;
}

function OnGUI () 
{
	GUI.Label(new Rect(centerx - 50, 25, 100, 25), "Bonjour client", labelStyle);
	service = GUI.TextField(new Rect(centerx - 125, 50, 175, 25), service);
	
	if (!querying && GUI.Button(new Rect(centerx + 50, 50, 75, 25), "Query"))
	{
		// Start lookup for specified service inside "local" domain
		Bonjour.StartLookup(service, "local");
		querying = true;
		status = "";
	}
	
	if (querying)
	{
		// Query status only every 10th frame. Managed -> Native calls are quite expensive.
		// Similar coding pattern could be considered as good practice. 
		if (Time.frameCount % 10 == 0)
		{
			status = Bonjour.GetLookupStatus();
			services = Bonjour.GetServiceNames();
			label = status;
		}
		
		if (status == "Done")
			querying = false;
		
		// Stop lookup	
		if (querying && GUI.Button(new Rect(centerx + 50, 50, 75, 25), "Stop"))
			Bonjour.StopLookup();
	}
	
	// Display status
	GUI.Label(new Rect(centerx - 50, 75, 300, 25), label, labelStyle);
	
	// List of looked up services
	for (var i : int = 0; i < services.Length; i++) 
	{
		GUI.Button(new Rect(centerx - 300, 100 + i * 25, 600, 25), services[i]);
	} 
}