using System;
using System.Windows.Controls;
using Hearthstone_Deck_Tracker.API;
using Hearthstone_Deck_Tracker.Plugins;

namespace HDT_Twitch_Prediction
{
    public class TwitchPrediction: IPlugin
    {
		public string Author
		{
			get { return "crashmax"; }
		}

		public string ButtonText
		{
			get { return "Settings"; }
		}

		public string Description
		{
			get { return "Twitch auto predictions."; }
		}

		public MenuItem MenuItem
		{
			get { return null; }
		}

		public string Name
		{
			get { return "TwitchPrediction"; }
		}

		public void OnLoad()
		{
			WebSocketClient.Connect();
			GameEvents.OnGameEnd.Add(WebSocketClient.OnStart);
			GameEvents.OnGameStart.Add(WebSocketClient.OnStart);
			GameEvents.OnGameWon.Add(WebSocketClient.OnWin);
			GameEvents.OnGameLost.Add(WebSocketClient.OnLose);
			GameEvents.OnGameTied.Add(WebSocketClient.OnTied);
		}

		public void OnUnload() => WebSocketClient.Disconnect();

		public void OnUpdate() { }

		public void OnButtonPress() { }

		public Version Version
		{
			get { return new Version(1, 0, 0); }
		}
	}
}
