using DesignPatterns.CommandPattern.Commands;
using DesignPatterns.CommandPattern.Invoker;
using DesignPatterns.CommandPattern.Recievers;

namespace DesignPatterns.CommandPattern
{
    public class CommandPatternTestDrive : TestDrive
    {
        public static void test()
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            Command lightOnCommand = new LightOnCommand(light);
            Command lightOffCommand = new LightOffCommand(light);
            remoteControl.setCommand(0, lightOnCommand, lightOffCommand);

            GarageDoor garageDoor = new GarageDoor();
            Command garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
            Command garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
            remoteControl.setCommand(1, garageDoorOpenCommand, garageDoorCloseCommand);

            Command[] onCommands = { lightOnCommand, garageDoorOpenCommand };
            Command[] offCommands = { lightOffCommand, garageDoorCloseCommand };

            Command macroOnCommand = new MacroCommand(onCommands);
            Command macroOffCommand = new MacroCommand(offCommands);

            remoteControl.setCommand(2, macroOnCommand, macroOffCommand);

            remoteControl.buttonOnPressed(0);
            Console.WriteLine();
            remoteControl.buttonOnPressed(1);
            Console.WriteLine("UNDO.....");
            remoteControl.buttonUndoPressed();
            Console.WriteLine();
            remoteControl.buttonOffPressed(1);
            Console.WriteLine("UNDO.....");
            remoteControl.buttonUndoPressed();
            Console.WriteLine("UNDO.....");
            remoteControl.buttonUndoPressed();
            Console.WriteLine();

            remoteControl.buttonOnPressed(2);
            Console.WriteLine();
            remoteControl.buttonOffPressed(2);
            Console.WriteLine();
            Console.WriteLine("UNDO.....");
            remoteControl.buttonUndoPressed();
            Console.WriteLine("UNDO.....");
            remoteControl.buttonUndoPressed();
        }
    }
}