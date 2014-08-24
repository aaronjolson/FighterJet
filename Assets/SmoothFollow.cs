using UnityEngine;
using System.Collections;

        public class SmoothFollow : MonoBehaviour {
        public Transform target;
        public float distance = 0.12f;
        public float height = 0.35f;
        public float followDamping = 5.0f;
		public float cameraOrientation = 0.5f;
        public bool smoothRotation = true;
        public bool followBehind = true;
        public float rotationDamping = 5.7f;

        void FixedUpdate () {
            Vector3 desiredPosition;
               if(followBehind)
			desiredPosition = target.TransformPoint(cameraOrientation, height, -distance);
               else
			desiredPosition = target.TransformPoint(cameraOrientation, height, distance);
     
               transform.position = Vector3.Lerp (transform.position, desiredPosition, Time.deltaTime * followDamping);

               if (smoothRotation) {
                       Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
                       transform.rotation = Quaternion.Slerp (transform.rotation, wantedRotation, Time.deltaTime * rotationDamping);
               }
               else transform.LookAt (target, target.up);

		if (followDamping < 5) {
			followDamping = 5;	
		}

         }
}