using UnityEngine;

public class script1 : MonoBehaviour
{
    public string ClientName;
    public int MoneyAmount;
    public int GetTotalInfo()
    {
        return MoneyAmount *2;
    }

    private string GetClientName()
    {
        return "Клиент:" + ClientName; 
    }

    public void AddMoney(int amount)
    {
        MoneyAmount+= amount;
    }

    public void SpendMoney(int amount)
    {
        if (MoneyAmount >= amount)
        {
            MoneyAmount -= amount;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ClientName = "Asanali";
        MoneyAmount = 700;

        print(ClientName);
        print(GetClientName());
        print(MoneyAmount);

        AddMoney(7);
        print(MoneyAmount);

    }

   
}
