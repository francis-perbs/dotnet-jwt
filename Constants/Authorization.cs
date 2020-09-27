namespace jwtapi
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Moderator,
            User
        }

        public const string default_username = "admin";
        public const string default_email = "admin@jwtapi.com";
        public const string default_password = "P@ssw0rd";
        public const Roles default_role = Roles.User;
    }
}