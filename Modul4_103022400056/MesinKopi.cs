using System;


namespace Modul4_103022400056
{
    public enum StateMesin
    {
        OFF,
        STANDBY,
        BREWING,
        MAINTENANCE
    }
    public class MesinKopi
    {
        private StateMesin state;
        public MesinKopi()
        {
            state = StateMesin.OFF;
        }
        public void PowerOn()
        {
            if (state == StateMesin.OFF)
            {
                state = StateMesin.STANDBY;
                Console.WriteLine("Mesin off menjadi standby");
            }
            else
            {
                Invalid();
            }
        }
        public void StartBrew()
        {
            if (state == StateMesin.STANDBY)
            {
                state = StateMesin.BREWING;
                Console.WriteLine("Mesin Standby menjadi brewing");
            }
            else
            {
                Invalid();
            }
        }
        public void FinishBrew()
        {
            if (state == StateMesin.BREWING)
            {
                state = StateMesin.STANDBY;
                Console.WriteLine("Mesin Brewing menjadi standby");
            }
            else
            {
                Invalid();
            }
        }
        public void StartMaintenace()
        {
            if (state == StateMesin.STANDBY)
            {
                state = StateMesin.MAINTENANCE;
                Console.WriteLine("Mesin standby menjadi Maintenance");
            }
            else
            {
                Invalid();
            }
        }
        public void FinishMaintenance()
        {
            if (state == StateMesin.MAINTENANCE)
            {
                state = StateMesin.STANDBY;
                Console.WriteLine("Mesin Maintenance menjadi Standby");
            }
            else
            {
                Invalid();
            }
        }
        public void PowerOFF()
        {
            if (state == StateMesin.STANDBY)
            {
                state = StateMesin.OFF;
                Console.WriteLine("Mesin Standby menjadi off");
            }
            else
            {
                Invalid();
            }
        }

        private void Invalid()
        {
            {
                Console.WriteLine("Perubahan State tidak valid");
            }
        }
    }
}
