using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour 
{
	void Start()
	{
		bool shouldContinue = false;
		
		do
		{
			print ("Hello Newman..."); 
		}while(shouldContinue ==true);

	}
}