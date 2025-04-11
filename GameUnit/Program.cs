using System;

namespace GameUnits
{
    public class Program
    {
        private static void Main()
        {
            // Criar array com três unidades
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            // Unidade 0 ataca unidade 1
            (units[0] as MilitaryUnit).Attack(units[1]);
            // Unidade 0 ataca unidade 2
            (units[0] as MilitaryUnit).Attack(units[2]);

            // "Imprimir" cada unidade
            // chamando implicitamente o método ToString() de cada uma delas
            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }
        }
    }
}