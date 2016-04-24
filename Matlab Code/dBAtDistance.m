function Y = dBAtDistance(fileName, distance)
    [P, ~] = fouriertransform(fileName, false);
    [~,r_o, const] = maxDistance(P);
    Y = 20*log10(soundint(distance,const,r_o));
end