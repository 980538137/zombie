using UnityEngine;
using System.Collections;

public class MainMenuController : MonoBehaviour {

    private Animator mainMenuAnimator;


    void Awake()
    {
        mainMenuAnimator = GetComponent<Animator>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MenuFade()
    {
        mainMenuAnimator.SetTrigger("FadeOut");
    }
}
