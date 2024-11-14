using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        // DEFINING LAMBDA FUNCTION IN X DIRECTION
        // beta = v/c -- maybe we set c = 1?
        // gamma = 1/sqrt(1-beta^2)

        float c_value = 299792458.0f;
        float c = 1.0f;
        Vector3 observer_velocity = new Vector3(0, 0, 0);
        float beta = 0; //non_cov_vel.magnitude / c;
        float gamma = 1 / Math.Sqrt(1 - beta ** 2);
        Matrix4x4 lambda = new Matrix4x4(
            row0: new Vector4(gamma, -1 * gamma * beta, 0, 0),
            row1: new Vector4(-1 * gamma * beta, gamma, 0, 0),
            row2: new Vector4(0, 0, 1, 0),
            row3: new Vector4(0, 0, 0, 1)
        );

        // DEFINING UNIT VECTOR
        // for now we test for fixed relative position

        GameObject particle = new GameObject();
        Vector3 dummyPosition = new Vector3(1, 2, 3);
        particle.position = dummyPosition;

        */ 
        // DEFINING COVARIANT VELOCITY AND LAMBDA
        Vector3 non_cov_vel = new Vector3(0.3f, 0.2f, 0.1f);
        // Vector4 is defined as x, y, z, w so we shift our usual time component of covariant 4 vector to the back - when it should be in the front. Keep in mind!
        Vector4 cov_vel = new Vector4(non_cov_vel.x, non_cov_vel.y, non_cov_vel.z, (float) Math.Sqrt(1 + non_cov_vel.magnitude));


        // Let's output in unity console where (relative) position is fixed
        float u_0 = cov_vel.w;
        float u_1 = cov_vel.x;
        float u_2 = cov_vel.y;
        float u_3 = cov_vel.z;
        Matrix4x4 lambda = new Matrix4x4();

        for(int i = 0; i <= 2; i++)
        {
            for (int j = 0; j <= 2; j++)
            {
                lambda[i, j] += (u_0 - 1) * cov_vel[i] * cov_vel[j] / ((float) Math.Pow(cov_vel.magnitude, 2));
            }
        }
        /*
        row0: new Vector4(u_0, -u_1, -u_2, -u_3),
        row1: new Vector4(-u_1, 1, 0, 0),
        row2: new Vector4(-u_2, 0, 1, 0),
        row3: new Vector4(-u_3, 0, 0, 1) 
        */


    }

    // Update is called once per frame
    void Update()
    {
        // user can set the speed of the viewer, and the position of the particle
        // calculate lambda_u of that particle

        // FUTURE: show the two particles side by side?


    }
}
