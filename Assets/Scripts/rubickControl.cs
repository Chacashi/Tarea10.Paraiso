using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubickControl : MonoBehaviour
{
	private Transform _compTransform;
	private SpriteRenderer _compSpriteRenderer;
	public float speed;
	public float xDirection;
	public float yDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        _compTransform = GetComponent<Transform>();
	_compSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
	_compTransform.position = new Vector2(_compTransform.position.x+speed * xDirection* Time.deltaTime,_compTransform.position.y + speed * yDirection * Time.deltaTime);
	if(_compTransform.position.x>=7.5)
	{
	  	xDirection = -1;
		if(_compSpriteRenderer.flipX==true){
		_compSpriteRenderer.flipX=false;
		}
		else{
		_compSpriteRenderer.flipX=true;
		}
	
		if(_compSpriteRenderer.flipY==true){
		_compSpriteRenderer.flipY=false;
		}
		else{
		_compSpriteRenderer.flipY=true;
		}  

	} 

	if(_compTransform.position.x<=-7.5)
	{
	  	xDirection= 1;
		if(_compSpriteRenderer.flipX==true){
		_compSpriteRenderer.flipX=false;
		}
		else{
		_compSpriteRenderer.flipX=true;
		}
	
		if(_compSpriteRenderer.flipY==true){
		_compSpriteRenderer.flipY=false;
		}
		else{
		_compSpriteRenderer.flipY=true;
	}  
	
	  
	}
	
	if(_compTransform.position.y>= 3.35)
	{
	  	yDirection = -1;
		if(_compSpriteRenderer.flipX==true){
		_compSpriteRenderer.flipX=false;
		}
		else{
		_compSpriteRenderer.flipX=true;
		}
	
		if(_compSpriteRenderer.flipY==true){
		_compSpriteRenderer.flipY=false;
		}
		else{
		_compSpriteRenderer.flipY=true;
		}  

					
	}
	
	if(_compTransform.position.y<= -3.35)
	{
	  	yDirection = 1;
		if(_compSpriteRenderer.flipX==true){
		_compSpriteRenderer.flipX=false;
		}
		else{
		_compSpriteRenderer.flipX=true;
		}
	
		if(_compSpriteRenderer.flipY==true){
		_compSpriteRenderer.flipY=false;
		}
		else{
		_compSpriteRenderer.flipY=true;
		}  

					
	}
     
    }
}
        
