<?php

namespace Classes;

final class BookingManager {
    public static function bookRoom($room,$reservation){
        self::checkIfFree($reservation,$room);

        $room->addReservation($reservation);

        echo "Room <strong>"
            .$room->getRoomNumber()
            ."</strong> successfully booked for <strong>"
            .$reservation->getGuest()->getFirstName()
            ." "
            .$reservation->getGuest()->getLastName()
            ."</strong> from <time>"
            .date(Reservation::DateFormat,$reservation->getStartDate())
            ."</time> to <time>"
            .date(Reservation::DateFormat,$reservation->getEndDate())
            ."</time>!"
            ."<br/>";
    }

    private static function checkIfFree($reservation,$room){
        foreach ($room->getReservations() as $value) {
            if (($reservation->getStartDate() >= $value->getStartDate() && $reservation->getStartDate()
                    <= $value->getEndDate()) ||
                ( $reservation->getEndDate() <= $value->getEndDate() && $reservation->getEndDate() >=
                    $value->getStartDate()) ||
                ($reservation->getStartDate() <= $value->getStartDate() &&
                    $reservation->getEndDate() >= $value->getEndDate())
            ) {
                throw new EReservationException("Room $room->getRoomNumber() is busy in that period");
            }
        }
    }
}