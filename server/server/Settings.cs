namespace server
{
    internal class Settings
    {
        public struct Values
        {
            //Get port from user settings
            public int GetPort()
            {
                return (int)Properties.Settings.Default.srv_port;
            }

            //Get update interval from settings
            public int GetUpdateInterval()
            {
                return 45;// Properties.Settings.Default.UpdateInterval;
            }

            //Get notify on connection from settings
            public bool GetNotifyValue()
            {
                return true;// Properties.Settings.Default.Notfiy;
            }
        }
    }
}
