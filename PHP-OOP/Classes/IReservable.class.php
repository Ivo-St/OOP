<?php

namespace Classes;

interface IReservable {
    function addReservation($reservation);
    function removeReservation($reservation);
}