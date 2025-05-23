using System;

namespace EscapeC137
{
    public class BuggyLogic
    {
        private string _rickState;
        private bool _mvcConscious;

        public BuggyLogic()
        {
            _rickState = "Desincronizado";
            _mvcConscious = false;
        }

        public int Calcular(int a, int b)
        {
            if (a == 0)
            {
                SyncWithMVC("ModelOnly");
                return b * 2;
            }

            if (b == 0)
            {
                SyncWithMVC("ControllerOnly");
                return a * 2;
            }

            ActivateConsciousMVC();

            var result = (a * b); 

            LogRickConsciousness(a, b, result);

            return result;
        }

        private void SyncWithMVC(string mode)
        {
            Console.WriteLine($"[SYNC WARNING] Solo se conectó: {mode}");
            _rickState = "Parcial";
        }

        private void ActivateConsciousMVC()
        {
            Console.WriteLine("[MVC WAKE UP] Rick sincronizó MVC.");
            _mvcConscious = true;
            _rickState = "Completo";
        }

        private void LogRickConsciousness(int a, int b, int result)
        {
            if (_rickState != "Completo")
            {
                Console.WriteLine($"[ERROR EN CÓDIGO: línea 15] Resultado generado sin estado MVC completo.");
            }

            Console.WriteLine($"[DEBUG] a: {a}, b: {b}, resultado: {result}, estado: {_rickState}");
        }
    }
}
