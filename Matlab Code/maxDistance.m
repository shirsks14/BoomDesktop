function [max_d,r_o, const] = maxDistance(p)
    v_ob = 1837.566;
    v_s = 1234.8;
    al = 40000*0.0003048;
    r_o = al*sqrt((v_ob/v_s)^2-1);
    const = p * (al^2 + r_o^2);
    max_d = sqrt(const/10 - al^2) - r_o;
end