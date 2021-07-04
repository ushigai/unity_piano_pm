using UnityEngine;
using System;
using System.Collections;

public class ParticleTrigger : MonoBehaviour
{
    Animator _animator;
    public GameObject key, keys;
    void OnNoteOn (MidiMessage midi)
    {

        int status, data1, data2;
        data1 = midi.data1;
        data2 = midi.data2;
        status = midi.status;
        
        float pos;
        pos = 60.0F;
        switch (data1)
        {
            case 21:
                pos = 5.99F;
                key = GameObject.FindWithTag("1_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("1_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 22:
                pos = 7.241F;
                key = GameObject.FindWithTag("1_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 23:
                pos = 8.592F;
                key = GameObject.FindWithTag("1_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("1_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 24:
                pos = 10.273F;
                key = GameObject.FindWithTag("2_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 25:
                pos = 11.656F;
                key = GameObject.FindWithTag("2_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 26:
                pos = 12.974F;
                key = GameObject.FindWithTag("2_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 27:
                pos = 14.296F;
                key = GameObject.FindWithTag("2_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 28:
                pos = 15.663F;
                key = GameObject.FindWithTag("2_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 29:
                pos = 17.356F;
                key = GameObject.FindWithTag("2_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 30:
                pos = 18.722F;
                key = GameObject.FindWithTag("2_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 31:
                pos = 20.025F;
                key = GameObject.FindWithTag("2_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 32:
                pos = 21.239F;
                key = GameObject.FindWithTag("2_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 33:
                pos = 22.489F;
                key = GameObject.FindWithTag("2_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 34:
                pos = 23.737F;
                key = GameObject.FindWithTag("2_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 35:
                pos = 25.097F;
                key = GameObject.FindWithTag("2_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("2_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 36:
                pos = 26.815F;
                key = GameObject.FindWithTag("3_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 37:
                pos = 28.141F;
                key = GameObject.FindWithTag("3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 38:
                pos = 29.486F;
                key = GameObject.FindWithTag("3_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 39:
                pos = 30.796F;
                key = GameObject.FindWithTag("3_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 40:
                pos = 32.209F;
                key = GameObject.FindWithTag("3_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 41:
                pos = 33.866F;
                key = GameObject.FindWithTag("3_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 42:
                pos = 35.218F;
                key = GameObject.FindWithTag("3_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 43:
                pos = 36.5F;
                key = GameObject.FindWithTag("3_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 44:
                pos = 37.75F;
                key = GameObject.FindWithTag("3_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 45:
                pos = 39.001F;
                key = GameObject.FindWithTag("3_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 46:
                pos = 40.291F;
                key = GameObject.FindWithTag("3_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 47:
                pos = 41.591F;
                key = GameObject.FindWithTag("3_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("3_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 48:
                pos = 43.241F;
                key = GameObject.FindWithTag("4_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 49:
                pos = 44.635F;
                key = GameObject.FindWithTag("4_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 50:
                pos = 45.998F;
                key = GameObject.FindWithTag("4_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 51:
                pos = 47.336F;
                key = GameObject.FindWithTag("4_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 52:
                pos = 48.681F;
                key = GameObject.FindWithTag("4_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 53:
                pos = 50.35F;
                key = GameObject.FindWithTag("4_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 54:
                pos = 51.706F;
                key = GameObject.FindWithTag("4_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 55:
                pos = 52.998F;
                key = GameObject.FindWithTag("4_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 56:
                pos = 54.261F;
                key = GameObject.FindWithTag("4_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 57:
                pos = 55.477F;
                key = GameObject.FindWithTag("4_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 58:
                pos = 56.743F;
                key = GameObject.FindWithTag("4_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 59:
                pos = 58.101F;
                key = GameObject.FindWithTag("4_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("4_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 60:
                pos = 59.809F;
                key = GameObject.FindWithTag("5_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 61:
                pos = 61.146F;
                key = GameObject.FindWithTag("5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 62:
                pos = 62.512F;
                key = GameObject.FindWithTag("5_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 63:
                pos = 63.819F;
                key = GameObject.FindWithTag("5_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 64:
                pos = 65.185F;
                key = GameObject.FindWithTag("5_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 65:
                pos = 66.875F;
                key = GameObject.FindWithTag("5_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 66:
                pos = 68.211F;
                key = GameObject.FindWithTag("5_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 67:
                pos = 69.501F;
                key = GameObject.FindWithTag("5_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 68:
                pos = 70.74F;
                key = GameObject.FindWithTag("5_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 69:
                pos = 72.004F;
                key = GameObject.FindWithTag("5_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 70:
                pos = 73.235F;
                key = GameObject.FindWithTag("5_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 71:
                pos = 74.601F;
                key = GameObject.FindWithTag("5_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("5_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 72:
                pos = 76.295F;
                key = GameObject.FindWithTag("6_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 73:
                pos = 77.627F;
                key = GameObject.FindWithTag("6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 74:
                pos = 79.01F;
                key = GameObject.FindWithTag("6_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 75:
                pos = 80.3F;
                key = GameObject.FindWithTag("6_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 76:
                pos = 81.691F;
                key = GameObject.FindWithTag("6_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 77:
                pos = 83.343F;
                key = GameObject.FindWithTag("6_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 78:
                pos = 84.72F;
                key = GameObject.FindWithTag("6_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 79:
                pos = 86.018F;
                key = GameObject.FindWithTag("6_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 80:
                pos = 87.198F;
                key = GameObject.FindWithTag("6_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 81:
                pos = 88.446F;
                key = GameObject.FindWithTag("6_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 82:
                pos = 89.726F;
                key = GameObject.FindWithTag("6_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 83:
                pos = 91.074F;
                key = GameObject.FindWithTag("6_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("6_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 84:
                pos = 92.744F;
                key = GameObject.FindWithTag("7_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 85:
                pos = 94.102F;
                key = GameObject.FindWithTag("7_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 86:
                pos = 95.462F;
                key = GameObject.FindWithTag("7_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 87:
                pos = 96.773F;
                key = GameObject.FindWithTag("7_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 88:
                pos = 98.154F;
                key = GameObject.FindWithTag("7_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 89:
                pos = 99.803F;
                key = GameObject.FindWithTag("7_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 90:
                pos = 101.178F;
                key = GameObject.FindWithTag("7_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 91:
                pos = 102.478F;
                key = GameObject.FindWithTag("7_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 92:
                pos = 103.709F;
                key = GameObject.FindWithTag("7_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 93:
                pos = 104.944F;
                key = GameObject.FindWithTag("7_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 94:
                pos = 106.241F;
                key = GameObject.FindWithTag("7_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 95:
                pos = 107.573F;
                key = GameObject.FindWithTag("7_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("7_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 96:
                pos = 109.271F;
                key = GameObject.FindWithTag("8_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_1_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 97:
                pos = 110.625F;
                key = GameObject.FindWithTag("8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 98:
                pos = 111.995F;
                key = GameObject.FindWithTag("8_3_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_3_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 99:
                pos = 113.314F;
                key = GameObject.FindWithTag("8_4");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 100:
                pos = 114.703F;
                key = GameObject.FindWithTag("8_5_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_5_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 101:
                pos = 116.327F;
                key = GameObject.FindWithTag("8_6_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_6_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 102:
                pos = 117.727F;
                key = GameObject.FindWithTag("8_7");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 103:
                pos = 119.01F;
                key = GameObject.FindWithTag("8_8_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_8_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 104:
                pos = 120.232F;
                key = GameObject.FindWithTag("8_9");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 105:
                pos = 121.474F;
                key = GameObject.FindWithTag("8_10_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_10_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 106:
                pos = 122.732F;
                key = GameObject.FindWithTag("8_11");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation2", 0, 0);
                break;
            case 107:
                pos = 124.121F;
                key = GameObject.FindWithTag("8_12_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                key = GameObject.FindWithTag("8_12_2");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            case 108:
                pos = 125.99F;
                key = GameObject.FindWithTag("9_1_1");
                _animator = key.GetComponent<Animator>();
                _animator.PlayInFixedTime("key_animation", 0, 0);
                break;
            default:
                pos = 0;
                
                break;
            
        }
        Transform myTransform = this.transform;
        Vector3 worldPos = myTransform.position;
        worldPos.x = pos;
        myTransform.position = worldPos;
        
        //GetComponent<ParticleSystem>().startSize = 2;
        GetComponent<ParticleSystem>().Emit (Mathf.Max(1));
        
    }
    
    
}
