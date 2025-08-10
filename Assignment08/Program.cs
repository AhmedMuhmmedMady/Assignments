namespace Assignment08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
            }
        }
    }
    #region Question 01:Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }
    public interface ICircle : IShape
    {
        double Radius { get; set; }
    }

    public interface IRectangle : IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius = {Radius} has Area = {Area}");
        }
    }
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with width = {Width} and height = {Height} has Area = {Area:F2}");
        }
    }
    #endregion

    #region Question 02:
    ////In this example,
    ////1-We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
    ////2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.
    ////3-In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference..
    ////This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);
        bool AuthorizeUser(string username, string role);
    }
    //public class BasicAuthenticationService : IAuthenticationService
    //{
    //public bool AuthenticateUser(string username, string password)
    //{

    //}
    //public bool AuthorizeUser(string username, string role)
    //{

    //}
    //}

    #endregion

    #region Question 03:
    /*1-we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
    2-We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
    3-In each implementation, we provide the logic to send notifications through the respective communication channel:
    4-The EmailNotificationService class simulates sending an email by outputting a message to the console.
    5-The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
    6-The PushNotificationService class simulates sending a push notification by outputting a message to the console.
    7-In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
    This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.
    */
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[Email] Sent to {recipient}: {message}");
        }
    }
    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[SMS] Sent to {recipient}: {message}");
        }
    }
    public class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"[Push Notification] Sent to {recipient}: {message}");
        }
    }
    #endregion

}
