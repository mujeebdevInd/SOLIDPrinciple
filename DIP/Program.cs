using DIP;

class Program
{
    static void Main(string[] args)
    {
        ILogger fileLogger = new FileLogger();
        UserService userServiceWithFileLogger = new UserService(fileLogger);
        userServiceWithFileLogger.RegisterUser("john_doe");

        ILogger databaseLogger = new DatabaseLogger();
        UserService userServiceWithDatabaseLogger = new UserService(databaseLogger);
        userServiceWithDatabaseLogger.RegisterUser("jane_doe");
    }
}