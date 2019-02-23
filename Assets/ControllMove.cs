using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;
using Leap.Unity;

public class ControllMove : MonoBehaviour {

    Controller controller;
    public float HandPalmPitch;
    public float HandPalmYam;
    public float HandPalmRoll;
    public float HandWristRot;


    // Use this for initialization
    void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        controller = new Controller();
        Frame frame = controller.Frame();
        List<Hand> hands = frame.Hands;
        if (frame.Hands.Count > 0)
        {
            Hand firstHand = hands[0];
        }

        HandPalmPitch = hands[0].PalmNormal.Pitch;
        HandPalmRoll = hands[0].PalmNormal.Roll;
        HandPalmYam = hands[0].PalmNormal.Yaw;

        HandWristRot = hands[0].PalmPosition.Pitch;

        Debug.Log(" mmmmmm Num: " + HandPalmYam);
    }
}
