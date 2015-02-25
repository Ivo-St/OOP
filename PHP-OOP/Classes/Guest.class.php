<?php

namespace Classes;

class Guest {
    private $firstName;
    private $lastName;
    private $id;

    public function __construct($firstName,$lastName,$id){
        $this->setFirstName($firstName);
        $this->setLastName($lastName);
        $this->setID($id);
    }

    public function getFirstName(){
        return $this->firstName;
    }

    public function setFirstName($firstName){
        $this->firstName=$firstName;
    }

    public function getLastName(){
        return $this->lastName;
    }

    public function setLastName($lastName){
        $this->lastName=$lastName;
    }

    public function getID(){
        return $this->id;
    }

    public function setID($id){
        $this->id=$id;
    }

    public function __toString(){
        $result = $this->getFirstName()
            . " "
            . $this->getLastName()
            . " "
            . $this->getID();

        return $result;
    }
}