class customer{
    int money;
    string job;
    string gender;
    string name;
    string surName;
    string title; //mr. ms. etc

    public customer(int money, string jobs, string gender, string name){
        //money, job, gender random
        console.writeline("What is your full name?");
        name = console.readLine();
        surName = name.Split(' ');
        consoæe.writeline("what is your title (Mr., Ms., Mrs. etc");
    }

}