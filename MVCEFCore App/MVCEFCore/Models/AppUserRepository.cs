namespace MVCEFCore.Models
{
    public class AppUserRepository
    {
        private readonly AppUserContext _db;

        public AppUserRepository(AppUserContext appUserContext)
        {
            _db = appUserContext;
        }

        public List<AppUser> GetAppUsers() 
        {
            return _db.AppUsers.ToList();
        }

        public AppUser AddSingleUser(AppUser appUser) 
        {
            _db.AppUsers.Add(appUser);

            _db.SaveChanges();

            return appUser;
        }
    }
}
