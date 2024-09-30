namespace api.model
{
    public interface loginrepos
    {
        void add(login loginn);
        List<login> GET();
        login GetByEmail(string email); 
    }
}
