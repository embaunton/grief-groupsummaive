using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
  
    public void ChangeToScene (string sceneToChangeto)
    {
        Application.LoadLevel (sceneToChangeto);

    }


}
