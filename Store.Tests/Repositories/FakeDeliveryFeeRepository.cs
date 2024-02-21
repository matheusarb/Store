using Store.Domain.Repositories.Interfaces;

public class FakeDeliveryFeeRepository : IDeliveryFeeRepository
{
    public decimal Get(string zipCode)
    {
        decimal deliveryFee = 0;
        if (zipCode == "12345678")
            deliveryFee = 10;

        return deliveryFee;
    }
}

