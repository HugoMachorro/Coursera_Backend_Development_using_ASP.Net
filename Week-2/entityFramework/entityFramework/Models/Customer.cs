namespace entityFramework.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

        //Comandos para migrar a DB
        //add-migration InitialMigrate
        //update-database

    }
}
