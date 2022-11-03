using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.EventSystems;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;

    public Vector3 posOffset;

    private Renderer rend; //A renderer is what makes an object appear on the screen.   
    public Color startColor; 

    BuildManager buildManager; //Refference to Line 30

    Shop shopscript; //Refference to line 32

    void Start() //Vooral dingen aanroepen of instantiation. 
    {
        buildManager = FindObjectOfType<BuildManager>(); //Roept de BuildManager script aan.

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;

        shopscript = gameObject.GetComponent<Shop>();
        }

    void OnMouseDown() //Wat gebeurt wanneer je klikt.
        {
            if (buildManager.GetTurretToBuild() == null)
            {
                return;
            }

            if (turret != null)
            {
                Debug.Log("Get logged bro");
                return;

            }

            GameObject turretToBuild = buildManager.GetTurretToBuild();
            turret = (GameObject)Instantiate(turretToBuild, transform.position + posOffset, transform.rotation); //Iets raars met de (GameObject) hierzo
            //turret.transform.parent = transform; //Misschien deze weer activeren als het niet werkt.

        }

    private void OnMouseEnter() //Als je muis erover heen hovert
    {
        Debug.Log(buildManager); //Laat mij zien of de buildManager wordt aangeroepen.
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        
        rend.material.color = hoverColor;

    }

    public void OnMouseExit()
    {
        rend.material.color = startColor;
    } //Wanneer je muis weg is van de Node.

}