using UnityEngine;
using System.Collections;

public class detection : MonoBehaviour
{

    public Transform character;

    public Material lightYellow;
    public Material lightBlack;

    public GameObject upset_surface;
    public GameObject sad_surface;
    public GameObject angry_surface;
    public GameObject big_eye_left;
    public GameObject big_eye_right;
    public GameObject big_mouth;
    public GameObject Rest_of_face;

    public GameObject ground_floor;


    public AudioClip changeMood;
    public AudioClip chorus1;
    Color[] colorChoices;


    int NeedToChangeDistance = 10;
    bool change = false;
    bool oldChange = false;
    float showTime = 3f;
    bool onetime = false;






void init()
    {

        Cursor.visible = false;


        /* floor */
        ground_floor.transform.GetComponent<Renderer>().material.color = Color.black;




        /* sad_surface */

        foreach (Transform BigCube in sad_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {
                    //Transform cubeattr = attrgameObj.transform.Find("Cube");
                    attrgameObj.GetComponent<Renderer>().material.color = Color.black;


                    //print(attrgameObj.name);
                }



                /* sad_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material.color = Color.black;


                    }





                }



            }



        }


        /* angry_surface */

        foreach (Transform BigCube in angry_surface.transform)
        {

            BigCube.GetComponent<Renderer>().material.color = Color.black;

            //print(attrgameObj.name);


        }


        /* angry_surface detail */

        foreach (Transform BigCube in angry_surface.transform)
        {


            foreach (Transform attrgameObj in BigCube)
            {


                foreach (Transform detail in attrgameObj)
                {
                    detail.GetComponent<Renderer>().material.color = Color.black;


                }



            }
            //print(attrgameObj.name);


        }



        /* upset_surface */

        foreach (Transform BigCube in upset_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {
                    //Transform cubeattr = attrgameObj.transform.Find("Cube");
                    attrgameObj.GetComponent<Renderer>().material.color = Color.black;


                    //print(attrgameObj.name);
                }



                /* upset_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material.color = Color.black;


                    }





                }



            }



        }





        //rest_of_face

        foreach (Transform BigCube in Rest_of_face.transform)
        {

            BigCube.GetComponent<Renderer>().material.color = Color.black;

            //print(attrgameObj.name);


        }


        // big_eye_left

        foreach (Transform BigCube in big_eye_left.transform)
        {

            BigCube.GetComponent<Renderer>().material.color = Color.black;

            //print(attrgameObj.name);


        }

        // big_eye_right

        foreach (Transform BigCube in big_eye_right.transform)
        {

            BigCube.GetComponent<Renderer>().material.color = Color.black;

            //print(attrgameObj.name);


        }

        // big_mouth

        foreach (Transform BigCube in big_mouth.transform)
        {

            BigCube.GetComponent<Renderer>().material.color = Color.black;

            //print(attrgameObj.name);


        }


    }


    void turnOnFace()
    {



        if (!onetime)
        {
            onetime = true;



            NormalStateOfface();
            // turn on Face




            GetComponent<AudioSource>().PlayOneShot(chorus1);





        }




    }


    void NormalStateOfface()
    {


        /* floor */
        ground_floor.transform.GetComponent<Renderer>().material.color = Color.white;




        /* sad_surface */

        foreach (Transform BigCube in sad_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {

                    attrgameObj.GetComponent<Renderer>().material = lightYellow;


                    //print(attrgameObj.name);
                }



                /* sad_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material = lightYellow;


                    }





                }



            }



        }


        /* angry_surface */

        foreach (Transform BigCube in angry_surface.transform)
        {

            BigCube.GetComponent<Renderer>().material = lightYellow;

            //print(attrgameObj.name);


        }


        /* angry_surface detail */

        foreach (Transform BigCube in angry_surface.transform)
        {


            foreach (Transform attrgameObj in BigCube)
            {


                foreach (Transform detail in attrgameObj)
                {
                    detail.GetComponent<Renderer>().material = lightYellow;


                }



            }


        }



        /* upset_surface */

        foreach (Transform BigCube in upset_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {
                    //Transform cubeattr = attrgameObj.transform.Find("Cube");
                    attrgameObj.GetComponent<Renderer>().material = lightYellow;


                    //print(attrgameObj.name);
                }



                /* upset_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material = lightYellow;


                    }





                }



            }



        }





        //rest_of_face

        foreach (Transform BigCube in Rest_of_face.transform)
        {
            BigCube.GetComponent<Renderer>().enabled = true;
            BigCube.GetComponent<Renderer>().material = lightYellow;

            //print(attrgameObj.name);


        }


        // big_eye_left

        foreach (Transform BigCube in big_eye_left.transform)
        {

            BigCube.GetComponent<Renderer>().enabled = true;
            BigCube.GetComponent<Renderer>().material = lightBlack;

            //print(attrgameObj.name);


        }

        // big_eye_right

        foreach (Transform BigCube in big_eye_right.transform)
        {
            BigCube.GetComponent<Renderer>().enabled = true;
            BigCube.GetComponent<Renderer>().material = lightBlack;

            //print(attrgameObj.name);


        }

        // big_mouth

        foreach (Transform BigCube in big_mouth.transform)
        {
            BigCube.GetComponent<Renderer>().enabled = true;
            BigCube.GetComponent<Renderer>().material = lightBlack;

            //print(attrgameObj.name);


        }


    }

    void Awake()
    {

        /*
        colorChoices[0] = Color.green;
        colorChoices[1] = Color.red;
        colorChoices[2] = Color.blue;*/

        init();




    }

    void Start()
    {



    }





    void Update()
    {

        showTime -= Time.deltaTime;
        if (showTime < 0)
        {
            turnOnFace();
        }



        if (character.position.z > NeedToChangeDistance)
        {

            change = true;

        }
        else
        {

            change = false;


        }

        // change other state when user go closer look
        if (change == true && oldChange == false)
        {
            oldChange = true;
            NewStateOfface();
            GetComponent<AudioSource>().PlayOneShot(changeMood);




        }
        else if (change == false && oldChange == true)
        {
            oldChange = false;
            NormalStateOfface();
            GetComponent<AudioSource>().PlayOneShot(changeMood);

        }


    }


    void NewStateOfface()
    {

        /* floor */
        ground_floor.transform.GetComponent<Renderer>().material.color = Color.black;




        /* sad_surface */

        foreach (Transform BigCube in sad_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {
                    Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                    attrgameObj.GetComponent<Renderer>().material.color = newColor;


                    //print(attrgameObj.name);
                }



                /* sad_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material.color = Color.black;


                    }





                }



            }



        }


        /* angry_surface */

        foreach (Transform BigCube in angry_surface.transform)
        {
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            BigCube.GetComponent<Renderer>().material.color = newColor;

            //print(attrgameObj.name);


        }


        /* angry_surface detail */

        foreach (Transform BigCube in angry_surface.transform)
        {


            foreach (Transform attrgameObj in BigCube)
            {


                foreach (Transform detail in attrgameObj)
                {
                    detail.GetComponent<Renderer>().material.color = Color.black;


                }



            }


        }



        /* upset_surface */

        foreach (Transform BigCube in upset_surface.transform)
        {



            foreach (Transform attrgameObj in BigCube)
            {


                if (attrgameObj.GetComponent<Renderer>())
                {



                    Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                    attrgameObj.GetComponent<Renderer>().material.color = newColor;


                    //print(attrgameObj.name);
                }



                /* upset_surface detail */
                foreach (Transform detail in attrgameObj)
                {


                    if (detail.GetComponent<Renderer>())
                    {

                        detail.GetComponent<Renderer>().material.color = Color.black;


                    }





                }



            }



        }





        //rest_of_face

        foreach (Transform BigCube in Rest_of_face.transform)
        {

            // BigCube.GetComponent<Renderer>().material.color = Color.black;
            BigCube.GetComponent<Renderer>().enabled = false;
            //print(attrgameObj.name);


        }


        // big_eye_left

        foreach (Transform BigCube in big_eye_left.transform)
        {

            //BigCube.GetComponent<Renderer>().material.color = Color.black;
            BigCube.GetComponent<Renderer>().enabled = false;
            //print(attrgameObj.name);


        }

        // big_eye_right

        foreach (Transform BigCube in big_eye_right.transform)
        {

            //BigCube.GetComponent<Renderer>().material.color = Color.black;
            BigCube.GetComponent<Renderer>().enabled = false;
            //print(attrgameObj.name);


        }

        // big_mouth

        foreach (Transform BigCube in big_mouth.transform)
        {

            //BigCube.GetComponent<Renderer>().material.color = Color.black;
            BigCube.GetComponent<Renderer>().enabled = false;
            //print(attrgameObj.name);


        }




    }




}




