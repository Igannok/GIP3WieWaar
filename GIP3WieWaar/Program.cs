// See https://aka.ms/new-console-template for more information
using GIP3WieWaar.logic;

bool loop = true;
UI ui = new UI();
Logic logic = new Logic();
int input;
string inputString;
int given;


do
{
    //start wordt getoond in Console
    Console.Clear();
    Console.WriteLine(ui.Welcome());
    Console.WriteLine(ui.Menu());
    inputString = Console.ReadLine();
    bool succes = int.TryParse(inputString, out input);
    if (succes && input <= 3)
    {
        switch (input)
        {
            case 1:
                
                
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(ui.Member());
                    string name = Console.ReadLine();
                    i = logic.RandomLogic(name,i);
                }
                
                //RandomLogic();
                Console.ReadLine();
                break;
            case 2:
                int resultTeamJT = 0;
                int resultTeamAW = 0;
                int resultSteven = 0;
                int resultJan = 0;

                foreach (KeyValuePair<Leden, int> entry in logic.InputMap)
                {
                    switch (entry.Key)
                    {

                        case Leden.Toby:
                        case Leden.Johan:
                            resultTeamJT += entry.Value;
                            break;
                        case Leden.Arthur:
                        case Leden.Wouter:
                            resultTeamAW += entry.Value;
                            break;
                        case Leden.Jan:
                            resultJan = entry.Value;
                            break;
                        case Leden.Steven:
                            resultSteven = entry.Value;
                            break;

                    }

                    Console.WriteLine($"{entry.Key} > {entry.Value}");
                }
                Console.WriteLine(ui.Results(resultTeamJT, resultTeamAW, resultJan, resultSteven));
                Console.WriteLine(logic.ResultsOrdered(resultTeamJT, resultTeamAW, resultJan, resultSteven));
                Console.ReadLine();
                Console.Clear();


                break;
            case 3:
                loop = false;
                Console.WriteLine(ui.Shutdown());
                Console.ReadLine();
                Console.Clear();
                break;
            default:
                Console.WriteLine("TRY AGAIN");
                break;

        }

    }
} while (loop);

