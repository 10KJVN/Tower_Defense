using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    public int currency = 101;
    Node nodescript;
    bool canPlace = true;


    void Start()
    {
        buildManager = BuildManager.instance;

    }
    internal void Update()
    {
        if (currency >= 100)
        {
            canPlace = true;
        }
        if (currency <= 100)
        {
            canPlace = false;
        }
    }

    public void PurchaseStandardTurret()
    {
        if (canPlace == true)
        {
            Debug.Log("Standard Turret Purchased");
            buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);
            currency -= 100;
        }


    }
}