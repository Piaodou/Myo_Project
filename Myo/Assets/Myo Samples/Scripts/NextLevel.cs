using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_manager : MonoBehaviour {

	public void OnClick(int SceneName){
		SceneManager.LoadScene(SceneName);
	}
	//public void OnClick(){
	//SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	//}
}