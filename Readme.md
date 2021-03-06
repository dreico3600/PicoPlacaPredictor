# "Pico y Placa Predictor"
###### By Diego Gallardo
<h4>Objetive</h4>
<p>Provide a web app that allows consulting the "Pico y Placa" vehicle restriction regulations that govern the city of Quito</p>

<h4>Functionality</h4>
<p>
    <ul>
        <li>Check the vehicle restriction based on:
            <ol>
                <li>the vehicle license plate</li>
                <li>the travel date and</li>
                <li>the estimated time of travel in which the vehicle is in the city of Quito</li>
            </ol>
        </li>
        <li>It has three message alerts:
            <ol>
                <li>No vehicular restriction, which can be on a weekend or a day of the week that does not comply with the restriction rules according to the license plate; </li>
                <li>Have a driving restriction on the selected date but not at the indicated time and</li>
                <li>Given the indicated date and time, the vehicle would be on the vehicle restriction schedule</li>
            </ol>
        </li>
    </ul>
</p>

<h4>Version 1.0</h4>
<p>
    This version releases the following functionality:
    <ol>
        <li>Use of razor primarily in the client interface</li>
        <li>BLL layer for consumption and creation of business rules for the vehicle restriction validation process</li>
        <li>Unit testing layer with the visual studio framework for BLL rules</li>
        <li>An automated test with SELENIUM for front end performance</li>
        <li>The data json is in github</li>
    </ol>
</p>
