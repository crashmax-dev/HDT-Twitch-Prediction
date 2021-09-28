using WebSocketSharp;

namespace HDT_Twitch_Prediction
{
    class WebSocketClient
    {
        static readonly WebSocket ws = new WebSocket("ws://localhost:7777");

        internal static void Connect() => ws.Connect();

        internal static void Disconnect() => ws.Close();

        internal static void OnStart() => ws.Send("start");

        internal static void OnWin() => ws.Send("win");

        internal static void OnLose() => ws.Send("lose");

        internal static void OnTied() => ws.Send("cancel");
    }
}
