using UnityEngine;
using System.Collections;

public class HUDController : MonoBehaviour {

    private Animator hudAnimator;

    void Awake()
    {
        hudAnimator = GetComponent<Animator>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void HudFade()
    {
        hudAnimator.SetTrigger("FadeIn");
    }
}
