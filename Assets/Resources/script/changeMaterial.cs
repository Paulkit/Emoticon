using UnityEngine;
using System.Collections;

public class changeMaterial : MonoBehaviour {
public GameObject whateverGameObject;
// Use this for initialization
void Start () {

Color whateverColor = new Color(0,0,0,1);

MeshRenderer gameObjectRenderer = whateverGameObject.GetComponent<MeshRenderer>();

Material newMaterial = new Material(Shader.Find("Whatever name of the shader you want to use"));

newMaterial.color = whateverColor;
gameObjectRenderer.material = newMaterial ;
}

// Update is called once per frame
void Update () {

}
}
