public interface IContainer<T>
{
    ICollection<T> Items
    {
        get;
        set;
    }
}

public class Person: IContainer<Address>, IContainer<Phone>, IContainer<Email>
{
    ICollection<Address> IContainer<Address>.Items {
        get {...}
        set {...}
    }

    ICollection<Phone> IContainer<Phone>.Items {
        get {...}
        set {...}
    }

    ICollection<Email> IContainer<Email>.Items {
        get {...}
        set {...}
    }
}

public class Person
{
    public ICollection<Address> MailAddresses { get; set; }
    public ICollection<Phone> PhoneNumbers { get; set; }
    public ICollection<Email> Emails { get; set; }
}