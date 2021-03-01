namespace Banking.Interfaces
{
    public interface IAccount
    {
        int Id{ get; }
        string Name{get; set;}
        string DateOfBirth{get; set;}
        string Address{get; set;}
        string ContactNumber {get; set;}
        double Balance { get; set;}
        void OpenAccount(int id, string Name, string DateOfBirth, string Address, string ContactNumber, double Balance);
    }
    
}