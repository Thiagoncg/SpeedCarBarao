using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayer : MonoBehaviour
{

    //public RPGCamera Camera;
    public CameraTracking Camera;

    void OnJoinedRoom()
    {
        CreatePlayerObject();
    }

    void CreatePlayerObject()
    {
        Vector3 position = new Vector3( 3f, -1.5f, 5f );

        GameObject newPlayerObject = PhotonNetwork.Instantiate( "CarCamaroAmarelo", position, Quaternion.identity, 0 );

        Camera.target = newPlayerObject.transform;
    }
}
