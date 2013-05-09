using UnityEngine;
using System.Collections;

public class Dragable : MonoBehaviour {
      
	Color mouseOverColor = Color.blue; 
	public Color originalColor = Color.white   ; 
	
	public void Start(){
		 originalColor = renderer.sharedMaterial.color ; 
	}
	
	void OnMouseEnter() {
		  renderer.material.color = mouseOverColor ;  
	}
	
	void OnMouseExit(){
		 renderer.material.color = originalColor ;  
	}
	
	IEnumerator OnMouseDown()
	{
		Vector3 mousePos1 = Input.mousePosition ; 
		while( Input.GetMouseButton(0))
		{
            /** 
             *获取射线:起点为摄像机,方向是摄像机与鼠标的向量方向 
             */

            if ( Vector3.Distance( mousePos1  , Input.mousePosition)>0.00001)
			{
				// this.renderer.enabled=false;
              
				Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition )  ; 			
				
				RaycastHit hitt = new RaycastHit();

                /** //射线碰撞到物体后,获取碰撞点即为要移动的点
               */
                
				Physics.Raycast( ray, out hitt ) ;
				
				transform.position = hitt.point;
				
				// this.renderer.enabled = true;	
				yield return 0 ;
				mousePos1 = Input.mousePosition ; 
			}
			yield return 0 ;			
		}
	}
}