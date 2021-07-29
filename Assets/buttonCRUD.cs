using UnityEngine;
using UnityEngine.UI;

public class buttonCRUD: MonoBehaviour
{
    public Button one, two, three, four, five;
    private GameObject cube;
    private Renderer cubeRenderer;
    private Vector3 scaleChange, originalPosition, originalScale;
   
    void Start()
    {
        //each button listens to the click event and if the event happens, execute the fuction inside the parenthesis.
        one.onClick.AddListener(Create);
        two.onClick.AddListener(Enlarge);
        three.onClick.AddListener(Rotate);
        four.onClick.AddListener(Reset);
        five.onClick.AddListener(Delete);

    }

    void Create()
    {
        //Create a cube and set its position, scale and color.
        originalPosition = new Vector3(120, 140, 0);
        originalScale = new Vector3(150, 150, 150);
        scaleChange = new Vector3(10, 10, 10);
        cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = originalPosition;
        cube.transform.localScale = originalScale;
        cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer.material.color = new Color32(212, 83, 118, 255);
        //Debug.Log("You have clicked the button!");
    }

    void Enlarge()
    {
        //increase the size of the button by the amount set in scaleChange
        cube.transform.localScale += scaleChange;
    }

    void Rotate()
    {
        //rotate the cube by 45 degree clockwise
        cube.transform.Rotate(0, 0, -45);

    }


    void Reset()
    {
        //reset the size and rotation of the cube
        cube.transform.localScale = originalScale;
        cube.transform.rotation = Quaternion.identity;
        
    }

    void Delete()
    {
        //delete the cube
        Destroy(cube);
    }
}