using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Neural_network : MonoBehaviour
{

    public Layer[] layers;
    public int[] networkShape = { 3, 5, 5, 4 };

    //public Layer hidden1;
    //public Layer hidden2;
    //public Layer output;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public class Layer
    {
        public float[,] wArray;
        public float[] bArray;
        public float[] nArray;

        private int Num_nodes;
        private int Num_inputs;

        public Layer(int Num_inputs, int Num_nodes) //used to give info to the Arrays
        {
            this.Num_nodes = Num_nodes;
            this.Num_inputs = Num_inputs;

            wArray = new float[Num_nodes, Num_inputs];
            bArray = new float[Num_nodes];
            nArray = new float[Num_nodes];

        }

        public void Forward(float[] inputsArray) //Forward pass funtion, excutes neural network equasion
        {
            nArray = new float[Num_nodes];

            for (int i = 0; i < Num_nodes; i++)
            {
                //sum of weight times inputs
                for (int j = 0; j < Num_inputs; j++)
                {
                    nArray[i] += wArray[i, j] * inputsArray[j];
                }

                //Add the bias
                nArray[i] += bArray[i];
            }
        }

        public void No_Zero() // Responsible for making nodes 0 if they are negative
        {
            for (int i = 0; i < Num_nodes; i++)
            {
                if (nArray[i] < 0)
                {
                    nArray[i] = 0;
                }
            }
        }

    }



    public float[] Brain(float[] inputs) // We give inputs and it gives output
    {
        for (int i = 0; i < layers.Length; i++)
        {
            if (i == 0)
            {
                layers[i].Forward(inputs);
                layers[i].No_Zero();
            }
            else if (i == layers.Length - 1)
            {
                layers[i].Forward(layers[i - 1].nArray);
            }
            else
            {
                layers[i].Forward(layers[i - 1].nArray);
                layers[i].No_Zero();
            }
        }

        // hidden1.Forward(inputs);
        // hidden1.Activation();
        // hidden2.Forward(hidden1.nodeArray);
        // hidden2.Activation();
        // output.Forward(hidden2.nodeArray);

        return (layers[layers.Length - 1].nArray);
    }

    public void Train()
    {

    }

    public void Awake() // Auto runs funtion if script is attached
    {
        layers = new Layer[networkShape.Length - 1];
        for (int i = 0; i < layers.Length; i++)
        {
            layers[i] = new Layer(networkShape[i], networkShape[i + 1]);
        }

        //hidden1 = new Layer(3, 5);
        //hidden2 = new Layer(5, 5);
        //output = new Layer(5, 4);
    }

}
