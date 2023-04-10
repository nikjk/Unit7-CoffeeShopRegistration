namespace Demo_Intro.Models
{
    public class MockDatabase
    {
        // This list acts as a table in a database.
        List<UserProfile> userProfiles = new List<UserProfile>
        {
            new UserProfile
            {
                FirstName = "John",
                LastName = "Doe",
                Bio = "A software developer with 5 years of experience.",
                ProfileImage = "https://example.com/john_doe_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Jane",
                LastName = "Doe",
                Bio = "A data analyst who enjoys solving complex problems.",
                ProfileImage = "https://example.com/jane_doe_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Max",
                LastName = "Mustermann",
                Bio = "A cat lover who is passionate about video games.",
                ProfileImage = "https://example.com/max_mustermann_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Emma",
                LastName = "Smith",
                Bio = "An avid traveler and photography enthusiast.",
                ProfileImage = "https://example.com/emma_smith_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Michael",
                LastName = "Johnson",
                Bio = "A fitness enthusiast and foodie who loves trying new recipes.",
                ProfileImage = "https://example.com/michael_johnson_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Emily",
                LastName = "Brown",
                Bio = "An artist who enjoys painting and drawing in her free time.",
                ProfileImage = "https://example.com/emily_brown_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "David",
                LastName = "Davis",
                Bio = "A music lover who plays the guitar and sings in his band.",
                ProfileImage = "https://example.com/david_davis_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Sophie",
                LastName = "Miller",
                Bio = "A nature lover who enjoys hiking and camping.",
                ProfileImage = "https://example.com/sophie_miller_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Oliver",
                LastName = "Wilson",
                Bio = "A tech geek who loves playing with new gadgets and technology.",
                ProfileImage = "https://example.com/oliver_wilson_profile.jpg"
            },
            new UserProfile
            {
                FirstName = "Ava",
                LastName = "Jones",
                Bio = "A cat lady who loves reading books and watching movies.",
                ProfileImage = "https://example.com/ava_jones_profile.jpg"
            },
        };

        public List<UserProfile> GetUserProfiles() 
        { 
            return userProfiles;
        }
    }
}
