
    
        using UnityEngine;
        using UnityEngine.InputSystem;

        public class PlayerMovement : MonoBehaviour
        {
            // we put information at the start of a class//
            
        public  int health = 100;
         public float speed = 4.5f;
          public string hero = "Redd";
          public bool isAlive = true;
          
          // xyz coordinates //
          public Vector3 direction;
          public Rigidbody playerRb;
          
           //start is called once before the first exectuion of an update after a monoBehaviour id created
            void Start()
            {
                Debug.Log("My name is " + hero);
            }
        
            // Update is called once per frame
            void Update()
            {
                // the dot is there to access a functionallity of transform 
                // transform.Translate(direction * Time.deltaTime * speed);

                playerRb.linearVelocity = direction * speed;
            }

            private void OnMove(InputValue value)
            {
                // asks the imput system what keys are being pressed 
                Vector2 inputValue = value.Get<Vector2>();
                direction = new Vector3(inputValue.x, 0, inputValue.y);
            }
        }
    

