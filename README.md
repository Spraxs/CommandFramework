# Command Framework

### 1. Classes:

 * [ReflectionUtil.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Utils/ReflectionUtil.cs)
 is used to handle all reflection in this project.
 * [Command.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs)
 handles all methods in a command class to be invoked with the right parameters.
 * [CommandHandler.cs](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Handlers/CommandHandler.cs)
 handles initializing the command classes to a [new Command](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs) object. It alse handles the player input so the [Command class](https://github.com/Spraxs/CommandFramework/blob/master/CommandFrameworkSolution/CommandFramework/Framework/Command.cs) can invoke the right method.
