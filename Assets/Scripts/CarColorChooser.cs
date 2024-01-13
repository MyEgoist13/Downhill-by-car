using UnityEngine;
using UnityEngine.SceneManagement;

public class CarColorChooser : MonoBehaviour
{
    public MeshRenderer mr;

    public Material AFRC_Emission;

    public Material[] carMaterials;

    public Material[] AFRC_Mat_Colors;

    public int colorCode = 0;

    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            if(PlayerPrefs.GetInt("colorCode") != 0)
            {
                colorCode = PlayerPrefs.GetInt("colorCode");
                carMaterials[1] = AFRC_Emission;
                carMaterials[0] = AFRC_Mat_Colors[colorCode];
            } else {
                carMaterials[1] = AFRC_Emission;
                carMaterials[0] = AFRC_Mat_Colors[0];
            }

            mr.materials = carMaterials;
        }
        //mr = Body.GetComponent<MeshRenderer>();
    }

    public void ChooseColor(bool NextColor)
    {
        if(colorCode < AFRC_Mat_Colors.Length - 1 && NextColor)
        {
            Debug.Log("Next");

            colorCode++;
            carMaterials[0] = AFRC_Mat_Colors[colorCode];
        }
        if(colorCode > 0 && !NextColor)
        {
            Debug.Log("Previous");

            colorCode--;
            carMaterials[0] = AFRC_Mat_Colors[colorCode];
        }
        mr.materials = carMaterials;

        PlayerPrefs.SetInt("colorCode", colorCode);
    }

    public void ChooseColor()
    {
        carMaterials[0] = AFRC_Mat_Colors[colorCode];
        mr.materials = carMaterials;

        PlayerPrefs.SetInt("colorCode", colorCode);
    }
}