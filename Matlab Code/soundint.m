function Y = soundint(distance, const, r_o)
    al = 40000*0.0003048;

    Y = const/(al^2 + (r_o+distance)^2);
    if(Y < 1);
        Y=1;
    end
end