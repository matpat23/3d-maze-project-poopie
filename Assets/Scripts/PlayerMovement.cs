
    
        using UnityEngine;
        using UnityEngine.InputSystem;

        public class PlayerMovement : MonoBehaviour
        {
            // we put information at the start of a class
            
        //public  int health = 100;
         public float speed = 4.5f;
         public float jumpForce = 5;
          public string hero = "Redd";
          //public bool isAlive = true;
          
          // xyz coordinates 
          public Vector3 direction;
          public Rigidbody playerRb;
          
           //start is called once before the first exectuion of an update after a monoBehaviour id created
            void Start()
            {
                Debug.Log("My name is " + hero);
            }
        
            // Update is called once per frame
            // Physics Loop
            void FixedUpdate()
            {
                // the dot is there to access a functionallity of transform 
                // transform.Translate(direction * Time.deltaTime * speed);

                Vector3 velocity = direction * speed;
                velocity.y = playerRb.linearVelocity.y;
                
                
                playerRb.linearVelocity = velocity;
            }

            private void OnMove(InputValue value)
            {
                // asks the imput system what keys are being pressed 
                Vector2 inputValue = value.Get<Vector2>();
                direction = new Vector3(inputValue.x, 0, inputValue.y);
            }

            private void OnJump(InputValue value)
            {
                // Physics.Raycsat will cast a line that can hit other colliders if it finds a collider //
                // it returns true if it doesnt, it returns false
                bool isGrounded = Physics.Raycast(transform.position, Vector3.down, 0.6f);
                if (isGrounded)
                {
                    playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                }
            }
        }
    

