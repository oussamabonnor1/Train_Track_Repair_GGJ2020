 using UnityEngine;
 
 public class Credits : MonoBehaviour
 {
     private float offset;
     public float speed = 29.0f;
     public GUIStyle style;
     public Rect viewArea;
 
     private void Start()
     {
         this.offset = this.viewArea.height;
     }
 
     private void Update()
     {
         this.offset -= Time.deltaTime * this.speed;
     }
 
     private void OnGUI()
     {
         GUI.BeginGroup(this.viewArea);
 
         var position = new Rect(0, this.offset, this.viewArea.width, this.viewArea.height);
         var text = @"Game IDEA = ZAKI BONNOR
            Game Dev = OUSSAMA BONNOR
            Design = -----------
            Beta Tester = All JAMERS ^_^";
 
         GUI.Label(position, text, this.style);
 
         GUI.EndGroup();
     }
 }