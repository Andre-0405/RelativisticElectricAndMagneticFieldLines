using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // DEFINING LAMBDA FUNCTION IN X DIRECTION
        // beta = v/c -- maybe we set c = 1?
        // gamma = 1/sqrt(1-beta^2)

        float c_value = 299792458.0;
        float c = 1.0;
        Vector3 observer_velocity = new Vector3(0, 0, 0);
        float beta = non_covariant_velocity.magnitude/c;
        float gamma = 1/Math.sqrt(1 - beta**2);
        Matrix4x4 lambda = new Matrix4x4(
            row0: new Vector4( gamma , -1 * gamma * beta , 0 , 0 ) ,
	        row1: new Vector4( -1 * gamma * beta , gamma , 0 , 0 ) ,
	        row2: new Vector4( 0 , 0 , 1 , 0 ) ,
	        row3: new Vector4( 0 , 0 , 0 , 1 )
        );

        // DEFINING UNIT VECTOR
        // for now we test for fixed relative position
        
        GameObject particle = new GameObject;
        Vector3 dummyPosition = new Vector3(1, 2, 3);
        particle.position = dummyPosition;

        // DEFINING COVARIANT VELOCITY AND LAMBDA
        Vector3 non_covariant_velocity = new Vector3(0.3, 0.2, 0.1);
        Vector3 covariant_velocity = new Vector4(Math.sqrt(1 + non_covariant_velocity.magnitude), non_covariant_velocity.x, non_covariant_velocity.y, non_covariant_velocity.z)


        // Let's output in unity console where (relative) position is fixed
        
    }

    // Update is called once per frame
    void Update()
    {
        // user can set the speed of the viewer, and the position of the particle
        // calculate lambda_u of that particle

        // FUTURE: show the two particles side by side?


    }
}
