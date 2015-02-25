<?php

namespace Classes;

class SingleRoom extends Room{
    public function __construct($number,$price){
        parent::__construct($number,$price,1,RoomType::Standart,true,false,["TV","air-conditioner"],[]);
    }
}